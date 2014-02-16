using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfCards
{
    public partial class Form1 : Form
    {
        private System.Collections.SortedList m_icons = new System.Collections.SortedList();
        private Hand m_Hand1 = new Hand();
        private Hand m_Hand2 = new Hand();
        private Button m_PickedUp;

        public Form1()
        {
            InitializeComponent();
        }

        private void SetUp()
        {
            Deck aDeck = new Deck(new Suit[] {Suit.Clubs, Suit.Diamonds}, 
                new FaceValue[] {FaceValue.King, FaceValue.Queen, FaceValue.Jack, FaceValue.Ten});

            aDeck.Shuffle();
            m_Hand1 = new Hand();
            m_Hand2 = new Hand();
            aDeck.Deal(new Hand[]{m_Hand1, m_Hand2});
            ShowHand(panel1, m_Hand1);
            ShowHand(panel2, m_Hand2);
        }

        private void ShowHand(Panel aPanel, Hand aHand)
        {
            aPanel.Controls.Clear();
            Card aCard;
            Button aButton;

            for (int i = 0; i < aHand.Count; i++)
            {
                aCard = aHand[i];

                //Make the button and add it to the form.
                aButton = new Button();
                aPanel.Controls.Add(aButton);

                //Modify the appearance.
                aButton.Image = (Image)m_icons[aCard.Suit];
                aButton.Text = aCard.FaceValue.ToString();
                aButton.TextAlign = ContentAlignment.BottomCenter;
                aButton.ForeColor = Color.Red;
                aButton.ImageAlign = ContentAlignment.TopCenter;
                aButton.FlatStyle = FlatStyle.Flat;
                aButton.Height = 40;

                //Locate the button on the panel.
                aButton.Top = 45 * i;
                //Save the associated card.
                aButton.Tag = aCard;
                //Add a MouseDown event to the new button.
                aButton.MouseDown += new System.Windows.Forms.MouseEventHandler(ButtonMouseDown);
            }
        }

        private void ButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            m_PickedUp = (Button)sender;
            ((Button)sender).DoDragDrop(sender, DragDropEffects.Move);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_icons.Add(Suit.Clubs, Image.FromFile(Application.StartupPath + @"\club.jpg"));
            m_icons.Add(Suit.Diamonds, Image.FromFile(Application.StartupPath + @"\diamond.jpg"));
            m_icons.Add(Suit.Hearts, Image.FromFile(Application.StartupPath + @"\heart.jpg"));
            m_icons.Add(Suit.Spades, Image.FromFile(Application.StartupPath + @"\spade.jpg"));
            SetUp();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            SetUp();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            Card theCard = (Card)m_PickedUp.Tag;
            if (!m_Hand1.Contains(theCard))
            {
                m_Hand1.Add(theCard);
                m_Hand2.Remove(theCard);
            }
            ShowHand(panel2, m_Hand2);
            ShowHand(panel1, m_Hand1);
            m_PickedUp = null;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            Card theCard = (Card)m_PickedUp.Tag;
            if (!m_Hand2.Contains(theCard))
            {
                m_Hand2.Add(theCard);
                m_Hand1.Remove(theCard);
            }
            ShowHand(panel1, m_Hand1);
            ShowHand(panel2, m_Hand2);
            m_PickedUp = null;
        }
    }
}
