namespace aula_19_03_2025
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_apresentar_Click(object sender, EventArgs e)
        {
            personagem heroi = new personagem(
                txt_nome.Text,
                cbx_classe.Text,
                Convert.ToInt32(nud_level.Value)

             );

            heroi.hp = Convert.ToInt32(nud_Hp);
            heroi.mp = Convert.ToInt32(nud_Mp);


            lbl_rsultado.Text = $"Nome: {heroi.nome}\n " +
                $" Classe{heroi.classe}\n " +
                $" Level: {heroi.level}\n " +
                $"HP: {heroi.hp}\n" +
                $"MP:  {heroi.mp}";
        }
    }
}
