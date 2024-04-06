namespace TotitoClasico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int banderadeturno = 1;
        int banderadeempate = 0;
        int jug1 = 0;
        int jug2 = 0;
        int empate = 0;

        private void reset()
        {
            lbljugador1.Text = jug1.ToString();
            lbljugador2.Text = jug2.ToString();
            lblempate.Text = empate.ToString();
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            banderadeempate = 0;
            if (banderadeturno == 1)
                banderadeturno = 2;
            else banderadeturno = 1;
        }

        private void agregarpuntos()
        {
            if (banderadeturno == 1)
            {
                jug1++;
            }
            else
                if (banderadeturno == 2)
            {
                jug2++;
            }
            reset();
        }
        private void comprobar()
        {
            banderadeempate++;
            if (btn1.Text == btn2.Text && btn1.Text == btn3.Text && btn1.Text != "")
            {
                MessageBox.Show("Felicidades Ganaste Jugador" + banderadeturno);
                agregarpuntos();
            }
            else
            if (btn4.Text == btn5.Text && btn4.Text == btn6.Text && btn4.Text != "")
            {
                MessageBox.Show("Felicidades Ganaste Jugador" + banderadeturno);
                agregarpuntos();
            }
            else
            if (btn7.Text == btn8.Text && btn7.Text == btn9.Text && btn7.Text != "")
            {
                MessageBox.Show("Felicidades Ganaste Jugador" + banderadeturno);
                agregarpuntos();
            }
            else
            if (btn1.Text == btn4.Text && btn1.Text == btn7.Text && btn1.Text != "")
            {
                MessageBox.Show("Felicidades Ganaste Jugador" + banderadeturno);
                agregarpuntos();
            }
            else
            if (btn2.Text == btn5.Text && btn2.Text == btn8.Text && btn2.Text != "")
            {
                MessageBox.Show("Felicidades Ganaste Jugador" + banderadeturno);
                agregarpuntos();
            }
            else
            if (btn3.Text == btn6.Text && btn3.Text == btn9.Text && btn3.Text != "")
            {
                MessageBox.Show("Felicidades Ganaste Jugador" + banderadeturno);
                agregarpuntos();
            }
            else
            if (btn1.Text == btn5.Text && btn1.Text == btn9.Text && btn1.Text != "")
            {
                MessageBox.Show("Felicidades Ganaste Jugador" + banderadeturno);
                agregarpuntos();
            }
            else
            if (btn3.Text == btn5.Text && btn3.Text == btn7.Text && btn3.Text != "")
            {
                MessageBox.Show("Felicidades Ganaste Jugador" + banderadeturno);
                agregarpuntos();
            }
            else
            if (banderadeempate == 9)
            {
                MessageBox.Show("Nadie Ganó, Es Empate");
                empate++;
                reset();
            }
        }
        private void escribir(Button a)
        {
            if (a.Text == "")
            {
                if (banderadeturno == 1)
                {
                    a.Text = "X";
                    comprobar();
                    banderadeturno = 2;
                }
                else
                    if (banderadeturno == 2)
                {
                    a.Text = "O";
                    comprobar();
                    banderadeturno = 1;
                }
            }
            else
                if (a.Text != "")
            {
                MessageBox.Show("Seleccione Otra Casilla");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            escribir(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            escribir(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            escribir(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            escribir(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            escribir(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            escribir(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            escribir(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            escribir(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            escribir(btn9);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
