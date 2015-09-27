using System;

public static class Program{

  static void Main(){
   
    int resultado = loguearse("usuario", "contraseña");
    if(resultado==1)
      iniciarBucle();
    else
      Console.WriteLine('Esta mal el usuario o la contraseña.');
  }

  private static int loguearse(string usuario, string contra){
  
    //Devuelve 1 si está logueado
    return 1;
  
  }
  
  private static void iniciarBucle(){
  
    while(true){
      string shouts = obtenerShouts();
      if(shouts!=null){
        likeShouts(shouts);
        responderShouts(shouts);
      }
    }
    
  }
  private static string obtenerShouts(){
    return "Hola soy un shout, otro shout más";
  }
  
  private static void likeShouts(string shout){
    ClaseEstaticaDesconocidaEInexistente.LikearShouts(shout);
  }
  
  private static void responderShouts(string shout){
    //Acá se fija si el shout dice niku
    if(shout.ToLower().Contains("niku"))
      ClaseEstaticaDesconocidaEInexistente.ResponderConAlgunaPelotudez(shout);
    //O si es un comando
    if(shout.StartsWith("!"))
      ClaseEstaticaDesconocidaEInexistente.ResponderConElComando(shout);
  }
}
