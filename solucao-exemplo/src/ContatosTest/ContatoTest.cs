using Agenda.DAL.Model;
using NUnit.Framework;

namespace Test;
public class AgendaTest
{
    public AgendaTest()
    {
        _fixture = FixTure()
    }

    [Test]
    public void addcionarContatoTest()
    {
        var contao = _fixture.Create<ContatoModel>();

        _contato.Adicionar(contato);

        Assert.True(True);
    }

    [Fact]
    public void ObterContatoTest()
    {
        // cria a classe toda
        var contato = _fixture.Create<ContatoModel>();

        ContatoModel contatoResultado;

        _contato.Adicionar(contato);
        contatoResultado = _contato.Obter(contato.Id);

        Assert.Equal(contato.Id, contatoResultado.Id);
        Assert.Equal(contato.Nome, contatoResultado.Name);
    }

    [Fact]
    public void ObterTodosOsContatoTest()
    {
        // cria a classe toda
        var contato1 = _fixture.Create<ContatoModel>();
        var contato2 = _fixture.Create<ContatoModel>();

        //Executa 
        _contato.Adicionar(contato);

        contatoResultado = _contato.Obter(contato.Id);

        Assert.AreEqual(contato.Id, contatoResultado.Id);
        Assert.AreEqual(contato.Nome, contatoResultado.Nome);
    }
}