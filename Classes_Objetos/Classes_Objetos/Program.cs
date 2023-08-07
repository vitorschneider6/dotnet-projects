using System;

namespace Classes_Objeto;

class Program
{
    static void Main(string[] args) { 
    }
}

public class Pagamento
{
    public int MyProperty { get; set; }

    public int Tampa { get; private set; }

	private int tampa;

	public int Endereco
	{
		get { return tampa; }
		set { tampa = value; }
	}

}

public class PagamentoCartao : Pagamento
{
	
}