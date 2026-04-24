using Lady.Interfaces;

namespace Lady;

public class Factory
{
    // DICIONARIO DE FUNÇõES DE CRIAÇÃO
    // Func<int,int,IShape> siginfica:
    // Uma função que tem dois parâmetros do tipo "int" (x,y)
    // e que retorna algo do tipo IShape
    public Dictionary<string, Func<int,int,IShape>> dict = [];
}