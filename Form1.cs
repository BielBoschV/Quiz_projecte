using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_projecte
{
    public partial class Form1 : Form
    {

        //variables del joc

        int RespostaCorrecta;
        int NumeroPregunta = 1;
        int puntuació;
        int percentatge;
        int totalPreguntes;

        public Form1()
        {
            InitializeComponent();

            Pregunta(NumeroPregunta);

            totalPreguntes = 6;
        }

        private void CorregeixResposta(object sender, EventArgs e)
        {
            var ObjecteEmissor = (Button)sender;
            int TagBoto = Convert.ToInt32(ObjecteEmissor.Tag);
            if (TagBoto == RespostaCorrecta)
            {
                puntuació++;
            }
            if (NumeroPregunta == totalPreguntes)
            {
                // Percentatge
                percentatge = (int)Math.Round((double)(puntuació * 100) / totalPreguntes);
                MessageBox.Show(
                    "Haz finalitzat el Quiz!" + Environment.NewLine +
                    "Has contestat " + puntuació + " preguntes correcte." + Environment.NewLine +
                    "El total del percentatge és " + percentatge + "%" + Environment.NewLine +
                    "Clica OK per tornar a jugar"
                    );
                puntuació = 0;
                NumeroPregunta = 0;
                Pregunta(NumeroPregunta);
            }
            NumeroPregunta++;
            Pregunta(NumeroPregunta);
        }



        private void Pregunta(int preguntes)
        {
            switch (preguntes)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.images;
                    LabPreg.Text = "Quin és l'equip que més Champions League té actualment?";
                    button1.Text = "Bayern";
                    button2.Text = "Liverpool";
                    button3.Text = "Milan";
                    button4.Text = "Madrid";
                    RespostaCorrecta = 4;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._16317998617620;
                    LabPreg.Text = "Quin ha sigut l'únic equip en guanyar aquesta competició";
                    button1.Text = "Napoles";
                    button2.Text = "Roma";
                    button3.Text = "West Ham";
                    button4.Text = "Fiorentina";
                    RespostaCorrecta = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.uel_4;
                    LabPreg.Text = "Quin equip ha guanyat més Europa League en tota la història";
                    button1.Text = "Sevilla";
                    button2.Text = "Atletico de Madrid";
                    button3.Text = "Juventus";
                    button4.Text = "Manchester United";
                    RespostaCorrecta = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.e296484ab443fd2f7ac66e19280e45e63fcc6756;
                    LabPreg.Text = "En quin d'aquests equips no ha estat Zlatan Ibrahimović?";
                    button1.Text = "Ajax";
                    button2.Text = "Malmö FF";
                    button3.Text = "Psv Eindhoven";
                    button4.Text = "Juventus";
                    RespostaCorrecta = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Mundial_Sudafrica_2010;
                    LabPreg.Text = "Qui va ser el Guanyador del Mundial de Sudàfrica?";
                    button1.Text = "Brasil";
                    button2.Text = "França";
                    button3.Text = "Espanya";
                    button4.Text = "Argentina";
                    RespostaCorrecta = 3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.los_entrenadores_deben_ser_820x546;
                    LabPreg.Text = "Quí és l'entrenador amb més títols en tota la història?";
                    button1.Text = "Pep Guardiola";
                    button2.Text = "Sir Alex Ferguson";
                    button3.Text = "Jose Mourinho";
                    button4.Text = "Arsène Wenger";
                    RespostaCorrecta = 2;
                    break;
            }
        }
    }
}

