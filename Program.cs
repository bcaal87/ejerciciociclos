// DECLARAMOS LAS VARIABLES

string nombreUsuarioGuardado;
string contraseñaUsuarioGuardado;
string nombreUsuario;
string contraseñaUsuario;
int intentos = 0;
bool sesionOK = false;

//Pedimos al usuario ingresar datos  - Crear cuenta usuario
Console.WriteLine("*******Nueva cuenta de Usuario******");
Console.Write("Ingrese su usuario");
nombreUsuarioGuardado = Console.ReadLine();
Console.Write("Ingrese su contraseña");
contraseñaUsuarioGuardado = Console.ReadLine();
Console.WriteLine("******¡Cuentra creada correctamente!");

//Ahora vamos a simular el inicio de sesión

do
{
    Console.WriteLine("******Bienvenido al portal web******");
    Console.WriteLine("Ingrese su usuario");
    nombreUsuario = Console.ReadLine();
    Console.Write("Escriba Contraseña: ");
    contraseñaUsuario = Console.ReadLine();

    if (nombreUsuario.Equals(nombreUsuarioGuardado) && contraseñaUsuario.Equals(contraseñaUsuarioGuardado))
    { 
    sesionOK = true;
        Console.WriteLine("¡Sesion iniciada correctamente");
    }else
    {
        intentos++;
        Console.WriteLine("Usuario y contraseña incorrecto, vuelva intentarlo");
    }         

}while(!sesionOK && intentos < 3);
if (sesionOK)
{
    Console.WriteLine("¡Bienvenido al sistema!");
}else
{
    if(intentos >=3)
    {
        Console.WriteLine("Haz realizado mas de tres intentos");
    }

}





