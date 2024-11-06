int menu_number;
do //Bucle del menú
{
    do
    {
        Console.Clear();
        Console.WriteLine("MENÚ:");
        Console.WriteLine("1. Crear array numérico");
        Console.WriteLine("2. Crear array numérico aleatorio");
        Console.WriteLine("3. Crear array numérico decimal");
        Console.WriteLine("4. Crear array numérico decimal aleatorio");
        Console.WriteLine("5. Crear array de cadenas");
        Console.WriteLine("6. Salir");
        Console.Write("Seleccione una opción: ");
        string valor = Console.ReadLine();
        if (int.TryParse(valor, out menu_number));
    } while (false);
    switch (menu_number) //Ingresar a las opciones del menú
    {
        case 1: //Menú de array numérico
            Console.Clear();
            Console.WriteLine("Array numérico creado");
            Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
            int numeros_length = int.Parse(Console.ReadLine());
            int[] numeros = new int[numeros_length];
            int int_menu_number;
            do
            {
                Console.Clear();
                Console.WriteLine("Array numérco:");
                Console.WriteLine($"Capacidad de {numeros_length}");
                Console.WriteLine("Qué acción desea llevar a cabo?");
                Console.WriteLine("1. Cambiar la capacidad del array");
                Console.WriteLine("2. Llenar el array");
                Console.WriteLine("3. Mostrar el array");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                int_menu_number = int.Parse(Console.ReadLine());
                switch (int_menu_number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
                        numeros_length = int.Parse(Console.ReadLine());
                        numeros = new int[numeros_length]; // Cambiar el tamaño del array
                        break;
                    case 2:
                        Console.Clear();
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            Console.WriteLine($"Inserte qué valores quiere almacenar en el {i + 1}° espacio:");
                            numeros[i] = int.Parse(Console.ReadLine()); //Insertar valores del array
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Aquí se muestran los valores ingresados con su ubicación:");
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            Console.WriteLine($"Ubicación: {i} --> Valor: {numeros[i]}"); //Mostrar valores del array
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear(); // Salir del submenú
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error. Valor no válido");
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (int_menu_number != 4);
            break;
        case 2: //Menú de array numérico random
            Console.Clear();
            Console.WriteLine("Array numérico aleatorio creado");
            Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
            int numeros_random_length = int.Parse(Console.ReadLine());
            int[] numeros_random = new int[numeros_random_length];
            int random_int_menu_number;
            int r_min = 0, r_max = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Array numérco aleatorio:");
                Console.WriteLine($"Capacidad de {numeros_random_length}");
                Console.WriteLine("Qué acción desea llevar a cabo?");
                Console.WriteLine("1. Cambiar la capacidad del array");
                Console.WriteLine("2. Seleccionar intervalo de aleatoriedad");
                Console.WriteLine("3. Llenar el array");
                Console.WriteLine("4. Mostrar el array");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                random_int_menu_number = int.Parse(Console.ReadLine());
                Random random = new Random();
                switch (random_int_menu_number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
                        numeros_random_length = int.Parse(Console.ReadLine());
                        numeros_random = new int[numeros_random_length]; // Cambiar el tamaño del array
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Inserte valor mínimo: ");
                        r_min = int.Parse(Console.ReadLine());
                        Console.Write("Inserte valor máximo: ");
                        r_max = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        for (int i = 0; i < numeros_random.Length; i++)
                        {
                            Console.WriteLine($"Generando número {i+1}...");
                            numeros_random[i] = random.Next(r_min, r_max+1); // Genera números aleatorios entre 1 y 100
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Aquí se muestran los valores ingresados con su ubicación:");
                        for (int i = 0; i < numeros_random.Length; i++)
                        {
                            Console.WriteLine($"Ubicación: {i} --> Valor: {numeros_random[i]}"); //Mostrar valores del array
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear(); // Salir del submenú
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error. Valor no válido");
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (random_int_menu_number != 5);
            break;
        case 3: //Menú de array numérico decimal
            Console.Clear();
            Console.WriteLine("Array numérico decimal creado");
            Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
            int numeros_decimales_length = int.Parse(Console.ReadLine());
            double[] numeros_decimales = new double[numeros_decimales_length];
            double double_menu_number;
            do
            {
                Console.Clear();
                Console.WriteLine("Array numérco decimal:");
                Console.WriteLine($"Capacidad de {numeros_decimales_length}");
                Console.WriteLine("Qué acción desea llevar a cabo?");
                Console.WriteLine("1. Cambiar la capacidad del array");
                Console.WriteLine("2. Llenar el array");
                Console.WriteLine("3. Mostrar el array");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                double_menu_number = int.Parse(Console.ReadLine());
                switch (double_menu_number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
                        numeros_length = int.Parse(Console.ReadLine());
                        numeros_decimales = new double[numeros_decimales_length]; // Cambiar el tamaño del array
                        break;
                    case 2:
                        Console.Clear();
                        for (int i = 0; i < numeros_decimales.Length; i++)
                        {
                            Console.WriteLine($"Inserte qué valores quiere almacenar en el {i + 1}° espacio:");
                            numeros_decimales[i] = double.Parse(Console.ReadLine()); //Insertar valores del array
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Aquí se muestran los valores ingresados con su ubicación:");
                        for (int i = 0; i < numeros_decimales.Length; i++)
                        {
                            Console.WriteLine($"Ubicación: {i} --> Valor: {numeros_decimales[i]}"); //Mostrar valores del array
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear(); // Salir del submenú
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error. Valor no válido");
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (double_menu_number != 4);
            break;
        case 4: //Menú de array numérico decimal random
            Console.Clear();
            Console.WriteLine("Array numérico decimal aleatorio creado");
            Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
            int numeros_decimales_random_length = int.Parse(Console.ReadLine());
            double[] numeros_decimales_random = new double[numeros_decimales_random_length];
            int random_double_menu_number;
            double rd_min = 0, rd_max = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Array numérco decimal aleatorio:");
                Console.WriteLine($"Capacidad de {numeros_decimales_random_length}");
                Console.WriteLine("Qué acción desea llevar a cabo?");
                Console.WriteLine("1. Cambiar la capacidad del array");
                Console.WriteLine("2. Seleccionar intervalo de aleatoriedad");
                Console.WriteLine("3. Llenar el array");
                Console.WriteLine("4. Mostrar el array");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                random_double_menu_number = int.Parse(Console.ReadLine());
                Random random_d = new Random();
                switch (random_double_menu_number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
                        numeros_decimales_random_length = int.Parse(Console.ReadLine());
                        numeros_decimales_random = new double[numeros_decimales_random_length]; // Cambiar el tamaño del array
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Inserte valor mínimo: ");
                        rd_min = double.Parse(Console.ReadLine());
                        Console.Write("Inserte valor máximo: ");
                        rd_max = double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        for (int i = 0; i < numeros_decimales_random.Length; i++)
                        {
                            Console.WriteLine($"Generando número {i + 1}...");
                            numeros_decimales_random[i] = rd_min + (random_d.NextDouble()*(rd_max - rd_min)); // Genera números aleatorios entre 1 y 100
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Aquí se muestran los valores ingresados con su ubicación:");
                        for (int i = 0; i < numeros_decimales_random.Length; i++)
                        {
                            Console.WriteLine($"Ubicación: {i} --> Valor: {numeros_decimales_random[i]}"); //Mostrar valores del array
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear(); // Salir del submenú
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error. Valor no válido");
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (random_double_menu_number != 5);
            break;
        case 5: //Menú de array de cadenas
            Console.Clear();
            Console.WriteLine("Array de cadenas creado");
            Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
            int cadenas_length = int.Parse(Console.ReadLine());
            string[] cadenas = new string[cadenas_length];
            int cadenas_menu_number;
            do
            {
                Console.Clear();
                Console.WriteLine("Array de cadenas:");
                Console.WriteLine($"Capacidad de {cadenas_length}");
                Console.WriteLine("Qué acción desea llevar a cabo?");
                Console.WriteLine("1. Cambiar la capacidad del array");
                Console.WriteLine("2. Llenar el array");
                Console.WriteLine("3. Mostrar el array");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                cadenas_menu_number = int.Parse(Console.ReadLine());
                switch (cadenas_menu_number)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Inserte la cantidad de espacios que desea para su arreglo:");
                        cadenas_length = int.Parse(Console.ReadLine());
                        cadenas = new string[cadenas_length]; // Cambiar el tamaño del array
                        break;
                    case 2:
                        Console.Clear();
                        for (int i = 0; i < cadenas.Length; i++)
                        {
                            Console.WriteLine($"Inserte qué valores quiere almacenar en el {i + 1}° espacio:");
                            cadenas[i] = Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Aquí se muestran los valores ingresados con su ubicación:");
                        for (int i = 0; i < cadenas.Length; i++)
                        {                            
                            Console.WriteLine($"Ubicación: {i} --> Valor: {cadenas[i]}"); //Mostrar valores del array
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear(); // Salir del submenú
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error. Valor no válido");
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (cadenas_menu_number != 4);
            break;
        case 6: //Salir del programa
            Console.Clear();
            Console.WriteLine("Terminó el programa");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Error. Valor no válido ultimo");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
    }
} while (menu_number != 6);