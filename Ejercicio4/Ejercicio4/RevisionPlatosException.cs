using System;

public class RevisionPlatosException : Exception
{
    public RevisionPlatosException() : base("Has pedido un plato que no existe!") { }
}
