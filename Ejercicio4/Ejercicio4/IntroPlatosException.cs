using System;

public class IntroPlatosException : Exception
{
    public IntroPlatosException() : base("Este plato no existe en nuestro menú! Escoje otro") { }
}
