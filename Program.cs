// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
//Números random del 1 al tres que son las opciones
int maquina = rnd.Next(1, 3);
int Jugador = 0;
int Computador = 0;
int puntosMaquina = 0;
int puntosJugador = 0;
string seguir = "Si";

while(seguir == "SI" || seguir == "Si" || seguir == "si") {

    Console.WriteLine("<< BIENVENIDO Al JUEGO PIEDRA PAPEL O TIJERAS >>");

    Console.WriteLine("\t\t<< MENU >>");
    Console.WriteLine("");
    Console.WriteLine("\t\t1. PIEDRA");
    Console.WriteLine("\t\t2. PAPEL");
    Console.WriteLine("\t\t3. TIJERAS\n");
    Console.WriteLine("Ingrese opcion");
    Jugador = Int32.Parse(Console.ReadLine());

    switch (maquina) {
        case 1:
            Console.WriteLine("La maquina eligio Papel");
            break;
        case 2:
            Console.WriteLine("La maquina eligio Papel");
            break;
        case 3:
            Console.WriteLine("La maquina eligio Tijera");
            break;
    }
   
    if (Jugador > 0 || Jugador <= 3) {
        switch (Jugador) { 
            case 1:
                if (Jugador == maquina) {
                    Jugador = Jugador + 0;
                    Computador = Computador + 0;
                    Console.WriteLine("Empate");
                }
                else if (Jugador > maquina) {
                    Jugador = Jugador + 1;
                    Console.WriteLine("Ganaste");
                    puntosJugador++;
                }
                else {
                    Computador = Computador + 1;
                    Console.WriteLine("Perdiste");
                    puntosMaquina++;
                }

                break;
            case 2:
                if (Jugador == maquina) {
                    Jugador = Jugador + 0;
                    Computador = Computador + 0;
                    Console.WriteLine("Empate");
                }
                else if (Jugador > maquina) {
                    Jugador = Jugador + 1;
                    Console.WriteLine("Ganaste");
                    puntosJugador++;
                }
                else {
                    Computador = Computador + 1;
                    Console.WriteLine("Perdiste");
                    puntosMaquina++;
                }

                break;
            case 3:
                if (Jugador == maquina) {
                    Jugador = Jugador + 0;
                    Computador = Computador + 0;
                    Console.WriteLine("Empate");
                }
                else if (Jugador > maquina) {
                    Jugador = Jugador + 1;
                    Console.WriteLine("Ganaste");
                    puntosJugador++;
                }
                else {
                    Computador = Computador + 1;
                    Console.WriteLine("Perdiste");
                    puntosMaquina++;
                }

                break;
        }
        Console.WriteLine("\n\tM A R C A D O R\n");
        Console.WriteLine($" Maquina {puntosMaquina} \tJugador {puntosJugador}");
        Console.WriteLine("¿Desea seguir jugando?");
        seguir = Console.ReadLine();
        Console.Clear();
    } else {
        Console.WriteLine("Elija una opcion valida");
    }
}

Console.Clear();
Console.WriteLine("¡Gracias por jugar!");
puntosJugador = 0;
puntosMaquina = 0;