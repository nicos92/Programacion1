﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
     public static class ElGanador
    {

        public static void MostrarGanador()
        {
            Console.Clear();
            Cartel.Ganador();

            MiGanador();

            ElTablero.TableroGanador();
            FunGl.PressTecla();
        }

        public static void MiGanador()
        {
            string frase = "El ganador es el jugador ";
            if (!Program.misVar.Turno)
            {
                ColorGl.ConsolaLetraGreen();
                Cartel.JuadorX();
                frase += "UNO X";
                FunGl.SeleccionPuntaje();
               

            }
            else
            {
                ColorGl.ConsolaLetraCyan();
                frase += "DOS O";
                Cartel.JuadorO();
                FunGl.SeleccionPuntaje();


            }

            string puntaje = "\nPUNTAJE\n\"Jugador Uno X\": "+Program.misVar.PuntoJugadorUno + "\n\"Jugador Dos O\": "+Program.misVar.PutnoJugadorDos;
            string tiempo = "\nTIEMPO\n\"Jugador Uno X\": " + Program.misVar.RelojUno.Elapsed + "\n\"Jugador Dos O\": " + Program.misVar.RelojDos.Elapsed;
            PFunAccesoArchivo.Escribir(frase + puntaje + tiempo);

        }

        public static bool Ganador() { return GanadorHorizontal() || GanadorVertical() || GanadorDiagonal(); }

        public static bool GanadorDiagonal()
        {
            if (ElTablero.posiciones[0, 0] == ElTablero.posiciones[1, 1] && ElTablero.posiciones[0, 0] == ElTablero.posiciones[2, 2])
                return true;


            if (ElTablero.posiciones[2, 0] == ElTablero.posiciones[1, 1] && ElTablero.posiciones[2, 0] == ElTablero.posiciones[0, 2])
                return true;

            return false;
        }

        public static bool GanadorVertical()
        {
            for (int i = 0; i < 3; i++)
            {
                if (ElTablero.posiciones[0, i] == ElTablero.posiciones[1, i] && ElTablero.posiciones[0, i] == ElTablero.posiciones[2, i])
                    return true;
            }
            return false;
        }

        public static bool GanadorHorizontal()
        {
            for (int i = 0; i < 3; i++)
            {
                if (ElTablero.posiciones[i, 0] == ElTablero.posiciones[i, 1] && ElTablero.posiciones[i, 0] == ElTablero.posiciones[i, 2])
                    return true;

            }
            return false;
        }

    }
}
