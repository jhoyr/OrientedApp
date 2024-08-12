using FluentAssertions;

namespace OrientedApp.Functions.Tests;

[TestClass()]
public class CalculatorTests
{
    /**
     * Após criar a classe de testes, adicione o teste ao código de produção.
     * 
     * A maneira mais fácil de adicionar um projeto de teste para testar um método específico em seu código é clicar com o botão direito
     * do mouse no método e selecionar Criar Testes de Unidade. Essa opção para gerar métodos de teste automaticamente está disponível 
     * para a maioria dos projetos do .NET.
     * 
     * As instruções Assert são o que determinam se o teste é aprovado ou não. Os diferentes tipos de declarações também ajudam a identificar
     * claramente qual parte do comportamento do código está provocando a falha do teste. Os testes podem falhar por motivos que vão além da
     * reprovação nos critérios de declaração, como exceções não detectadas ou limites de tempo do teste atingidos.
     * 
     * **/
    [TestMethod()]
    public void AddTest()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var actual = calculator.Add(1, 1);
        var subtractActual = calculator.Subtract(actual, 1) == 1;

        // Assert
        Assert.IsNotNull(calculator); //Verifica se o objeto especificado é nulo e gera uma exceção se ele é nulo.
        Assert.AreEqual(2, actual); //Verifica se os dois objetos ou valores de entrada são iguais.
        Assert.IsTrue(subtractActual); //Verifica se a condição de entrada é verdadeira, Também há IsFalse para declarar que uma condição é falsa.
        StringAssert.Contains(actual.ToString(), "2"); //Verifica se a cadeia de caracteres contém uma substring específica.
                                                       //Há muitas outras declarações de cadeia de caracteres. Por exemplo, Matches verifica se há alguma expressão regular correspondente.
                                                       //StartsWith verifica se a cadeia de caracteres começa com uma substring especificada.

    }
    [TestMethod()]
    public void SubtractTest()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var actual = calculator.Subtract(1, 1);

        //Assert
        Assert.AreEqual(0, actual);
    }

    [TestMethod()]
    public void MultiplyTest()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var actual = calculator.Multiply(1, 1);

        //Assert
        Assert.AreEqual(1, actual);
    }

    [TestMethod()]
    public void DivideTest()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var actual = calculator.Divide(1, 1);

        //Assert
        Assert.AreEqual(1, actual);
    }

    [TestMethod()]
    public void DivideByZeroTest()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var actual = calculator.Divide(1, 0);

        //Assert
        Assert.IsNull(actual);
    }

    [TestMethod()]
    public void AddTestAssertion()
    {
        var calculator = new Calculator();
        var actual = calculator.Add(1, 1);

        // Non-fluent asserts:
        // Assert.AreEqual(actual, 2);
        // Assert.AreNotEqual(actual, 1);

        // Same asserts as what is commented out above, but using Fluent Assertions
        actual.Should().Be(2).And.NotBe(1);
    }
    /*TESTES DIRECIONADOS A DADOS*/

}
