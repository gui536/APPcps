using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APPcps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked() { 
        }


        private void Btn_metrosPolegadas_Clicked(object sender, EventArgs e) {
            try {
                double medida = Double.Parse(txt_medida.Text);

                double res = medida * 39.3701;
                string resultado = res.ToString();
                txt_convert.Text = medida + "m em Polegadas: " + resultado.ToString();
            }
            catch(Exception ex) {
                txt_convert.Text = "Desculpe, ocorreu um erro";
                Console.Out.WriteLine("Erro" + ex.Message);
            }
        }

        private void Btn_polegadasMetros_Clicked(object sender, EventArgs e)
        {
            try
            {
                double medida = Double.Parse(txt_medida.Text);

                double res = medida / 39.3701;
                string resultado = res.ToString();
                txt_convert.Text = medida + "pol em metros: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                txt_convert.Text = "Desculpe, ocorreu um erro \n " + ex.Message;
                Console.Out.WriteLine("Erro" + ex.Message);
            }
        }

        private void Btn_metrosPes_Clicked(object sender, EventArgs e)
        {
            try
            {
                double medida = Double.Parse(txt_medida.Text);

                double res = medida * 3.28084;
                string resultado = res.ToString();
                txt_convert.Text = medida + "m em Pés: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                txt_convert.Text = "Desculpe, ocorreu um erro \n " + ex.Message;
                Console.Out.WriteLine("Erro" + ex.Message);
            }
        }

        private void Btn_pesMetros_Clicked(object sender, EventArgs e)
        {
            try
            {
                double medida = Double.Parse(txt_medida.Text);

                double res = medida / 3.28084;
                string resultado = res.ToString();
                txt_convert.Text = medida + "pés em Metros: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                txt_convert.Text = "Desculpe, ocorreu um erro \n " + ex.Message;
                Console.Out.WriteLine("Erro" + ex.Message);
            }
        }
    }
}
