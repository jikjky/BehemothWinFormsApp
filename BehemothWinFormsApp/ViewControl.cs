using BehemothWinFormsApp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BehemothWinFormsApp
{
    public partial class ViewControl : UserControl
    {
        Party Party { get; set; } = new Party();

        public ViewControl()
        {
            InitializeComponent();
            Update();
        }

        public void SetParty(int order)
        {
            Party.DepartureOrder = order;
        }

        private void buttonCombinationsClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                PartyCombinations partyCombinations;
                if (Enum.TryParse<PartyCombinations>(button.Text, out partyCombinations))
                {
                    if (Party.OKPartyCombinations(partyCombinations))
                    {
                        Party.Add(partyCombinations);
                    }
                }
            }
            Update();
        }

        private void Update()
        {
            int playerIndex = 0;
            foreach (var item in Party.Players)
            {
                switch (playerIndex)
                {
                    case 0:
                        textBoxPlayer1.Text = item.GetPlayerPartyCombinations().ToString();
                        break;
                    case 1:
                        textBoxPlayer2.Text = item.GetPlayerPartyCombinations().ToString();
                        break;
                    case 2:
                        textBoxPlayer3.Text = item.GetPlayerPartyCombinations().ToString();
                        break;
                    case 3:
                        textBoxPlayer4.Text = item.GetPlayerPartyCombinations().ToString();
                        break;
                }
                playerIndex++;
            }
            if (playerIndex == 0)
            {
                textBoxPlayer1.Text = string.Empty;
                buttonRemove1.Enabled = false;
                buttonRemove2.Enabled = false;
                buttonRemove3.Enabled = false;
                buttonRemove4.Enabled = false;
            }
            if (playerIndex == 1)
            {
                textBoxPlayer2.Text = string.Empty;
                textBoxPlayer3.Text = string.Empty;
                textBoxPlayer4.Text = string.Empty;
                buttonRemove1.Enabled = true;
                buttonRemove2.Enabled = false;
                buttonRemove3.Enabled = false;
                buttonRemove4.Enabled = false;
            }
            if (playerIndex == 2)
            {
                textBoxPlayer3.Text = string.Empty;
                textBoxPlayer4.Text = string.Empty;
                buttonRemove1.Enabled = true;
                buttonRemove2.Enabled = true;
                buttonRemove3.Enabled = false;
                buttonRemove4.Enabled = false;
            }
            if (playerIndex == 3)
            {
                textBoxPlayer4.Text = string.Empty;
                buttonRemove1.Enabled = true;
                buttonRemove2.Enabled = true;
                buttonRemove3.Enabled = true;
                buttonRemove4.Enabled = false;
            }
            if (playerIndex == 4)
            {
                buttonRemove1.Enabled = true;
                buttonRemove2.Enabled = true;
                buttonRemove3.Enabled = true;
                buttonRemove4.Enabled = true;
            }
            foreach (PartyCombinations item in Enum.GetValues(typeof(PartyCombinations)))
            {
                switch (item)
                {
                    case PartyCombinations.DDDD:
                        buttonDDDD.Enabled = Party.OKPartyCombinations(item);
                        break;
                    case PartyCombinations.DDDS:
                        buttonDDDS.Enabled = Party.OKPartyCombinations(item);
                        break;
                    case PartyCombinations.DDSS:
                        buttonDDSS.Enabled = Party.OKPartyCombinations(item);
                        break;
                    case PartyCombinations.DSSS:
                        buttonDSSS.Enabled = Party.OKPartyCombinations(item);
                        break;
                    case PartyCombinations.SDDD:
                        buttonSDDD.Enabled = Party.OKPartyCombinations(item);
                        break;
                    case PartyCombinations.SDDS:
                        buttonSDDS.Enabled = Party.OKPartyCombinations(item);
                        break;
                    case PartyCombinations.SDSS:
                        buttonSDSS.Enabled = Party.OKPartyCombinations(item);
                        break;
                    case PartyCombinations.SSSS:
                        buttonSSSS.Enabled = Party.OKPartyCombinations(item);
                        break;
                    default:
                        break;
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Tag?.ToString() == "1")
                {
                    Party.Remove(Party.Players[0]);
                }
                if (button.Tag?.ToString() == "2")
                {
                    Party.Remove(Party.Players[1]);
                }
                if (button.Tag?.ToString() == "3")
                {
                    Party.Remove(Party.Players[2]);
                }
                if (button.Tag?.ToString() == "4")
                {
                    Party.Remove(Party.Players[3]);
                }
                Update();
            }
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            textBoxMake.Text = Party.Make();
        }
    }
}

