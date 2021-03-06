﻿using CinemaPIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaPIM.Repos
{
    class CadeirasRepo: Database
    {
        public CadeirasRepo()
        {
           
        }

        public void newCadeira(cadeira newCadeira)
        {
            int id = newCadeira.Id;
            int idSala = newCadeira.Sala;
            string linha = newCadeira.Linha;
            int columna = newCadeira.Columna;


            string query = "INSERT INTO `cadeiras`(`id`, `id_sala_id`, `linha`, `columna`) VALUES (" + id + "," + idSala + "," + "'" + linha + "'" + "," +
               columna + ");";
            Insert(query);
        }

        public int lastCadeira()
        {
            int id;
            string query = "SELECT CASE WHEN COUNT(`id`) <  1 THEN 0 ELSE  MAX(`id`) END AS `id`  FROM `cadeiras`";

            id = Count(query);

            if (id==0)
            {
                return 1;
            }
            return id;
        }

    }
}
