using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexGame
{
    public partial class new_game_form : Form
    {
        public new_game_form()
        {
            InitializeComponent();
        }

        GameParameters.PlayerType type1 = GameParameters.PlayerType.NONE;
        GameParameters.PlayerType type2 = GameParameters.PlayerType.NONE;

        private void start_game_button_Click(object sender, EventArgs e)
        {

            if(type1 == GameParameters.PlayerType.NONE || type2 == GameParameters.PlayerType.NONE)
            {
                MessageBox.Show("Erreur, veuillez séléctionner le type de joueur bleu et rouge.");
                return;
            }


            GameParameters parameters = new GameParameters((int) grid_size_prompt.Value, type1, type2);
            MessageBox.Show("Lancement de la partie.\n\nParamètres :\n- Taille de grille : " + parameters.getGridSize() + "\n- Joueur bleu : " + parameters.getBluePlayerType().ToString()+ "\n- Joueur rouge : " + parameters.getRedPlayerType().ToString()) ;

            new Game(parameters).Show();
            Hide();
        
        }

        private void blue_player_type_prompt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (blue_player_type_prompt.SelectedIndex)
            {
                case 0:
                    type1 = GameParameters.PlayerType.HUMAN;
                    break;
                case 1:
                    type1 = GameParameters.PlayerType.BRUTFORCE_AI_1;
                    break;
            }
        }

        private void red_player_type_prompt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (red_player_type_prompt.SelectedIndex)
            {
                case 0:
                    type2 = GameParameters.PlayerType.HUMAN;
                    break;
                case 1:
                    type2 = GameParameters.PlayerType.BRUTFORCE_AI_1;
                    break;
            }
        }
    }

    public class GameParameters
    {
        int grid_size = 1;
        PlayerType blue_player_type = PlayerType.NONE;
        PlayerType red_player_type = PlayerType.NONE;

        public GameParameters(int grid_size, PlayerType blue_player_type, PlayerType red_player_type)
        {
            this.grid_size = grid_size;
            this.blue_player_type = blue_player_type;
            this.red_player_type = red_player_type;
        }

        public int getGridSize()
        {
            return grid_size;
        }

        public PlayerType getBluePlayerType()
        {
            return blue_player_type;
        }

        public PlayerType getRedPlayerType()
        {
            return red_player_type;
        }

        public enum PlayerType
        {
            NONE, HUMAN, BRUTFORCE_AI_1
        }
    }
}
