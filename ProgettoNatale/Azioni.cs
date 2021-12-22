﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

namespace ProgettoNatale
{
    public partial class Azioni : Form
    {
        public Azioni(SqlConnection connection)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void View_Kids_Click(object sender, EventArgs e) //Inserimento dati dei bambini quando si clicca
        {
            List<Bambino> Bambini_Sfruttati = new List<Bambino>();
            Random rand = new Random(DateTime.Now.Second);
            RandomName nameGen = new RandomName(rand);
            List<string> Names = nameGen.RandomNames(2000, 0);
            Random rnd = new Random();
            foreach (string name in Names)
            {
                string[] arrGay = name.Split(' ');
                int eta = rnd.Next(1, 9);
                int bonta = rnd.Next(0, 101);
                //Aggiungere la nazione
                Bambini_Sfruttati.Add(new Bambino { Nome = arrGay[0], Cognome = arrGay[1], Eta = eta, Bonta = bonta});
            }

            File.WriteAllText("ListaBambini.json", JsonConvert.SerializeObject(Bambini_Sfruttati));
        }

        private void View_Gifts_Click(object sender, EventArgs e)//Inserimento dati dei regali quando si clicca
        {
            

        }

        private void Search_Click(object sender, EventArgs e)   //Ricerca tra tabelle 
        {

        }

        /// <summary>
        /// La mappa sarà composta da un dato orario e una tabella con i bambini e i regali,
        /// l'orario è collegato ad una certa nazione, sarà presente un bottone che modifica l'orario 
        /// mandandolo avanti di un'ora. Quindi le tabelle vengono aggiornate togliendo i bambini 
        /// che hanno ricevuto il regalo in quella deterinata nazione..
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Bambino
    {
        public string Nome;
        public string Cognome;
        public int Eta;
        public string Nazione;
        public int Bonta;
    }
}
