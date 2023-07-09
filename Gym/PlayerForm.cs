using System;
using System.Windows.Forms;
using Gym.Model;

namespace Gym
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void PlayerSaveBtn_Click(object sender, EventArgs e)
        {
            string Name = PlayerNameTb.Text, National = PlayerNationalTb.Text, Position = PlayerPositionTb.Text;
            int Age = 0, Goals = 0, Number = 0, ContractValue = 0;

            int.TryParse(PlayerAgeTb.Text, out Age);
            int.TryParse(PlayerContractValyeTb.Text, out ContractValue);

            if (PlayerSaveBtn.Text == "ذخیره")
            {
                Player Player = new Player(Name, National, Age, Number, Goals, ContractValue, Position);
                Player.Save();

                this.Close();
            }

            if (PlayerSaveBtn.Text == "ویرایش")
            {
                Player Player = new Player(Name, National, Age, Number, Goals, ContractValue, Position);
                Player.Edit(AccessibleName);

                this.Close();
            }
        }

        private void PlayerRmBtn_Click(object sender, EventArgs e)
        {
            string Name = PlayerNameTb.Text, National = PlayerNationalTb.Text, Position = PlayerPositionTb.Text;
            int Age = 0, Goals = 0, Number = 0, ContractValue = 0;

            int.TryParse(PlayerAgeTb.Text, out Age);
            int.TryParse(PlayerContractValyeTb.Text, out ContractValue);

            Player Player = new Player(Name, National, Age, Number, Goals, ContractValue, Position);
            Player.Delete(AccessibleName);

            this.Close();
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            if (AccessibleName == null)
            {
                PlayerRmBtn.Hide();

                return;
            }

            Player Player = Player.Show(AccessibleName);

            PlayerNameTb.Text = Player.Name;
            PlayerNationalTb.Text = Player.National;
            PlayerPositionTb.Text = Player.Position;
            PlayerAgeTb.Text = Convert.ToString(Player.Age);
            PlayerNumberTb.Text = Convert.ToString(Player.Number);
            PlayerGoalsTb.Text = Convert.ToString(Player.Gaols);
            PlayerContractValyeTb.Text = Convert.ToString(Player.ContractValue);

            PlayerFormTitle.Text = "ویرایش ورزشکار" + " " + AccessibleDescription;
            PlayerSaveBtn.Text = "ویرایش";
        }
    }
}
