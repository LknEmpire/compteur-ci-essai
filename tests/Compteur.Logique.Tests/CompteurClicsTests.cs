using Compteur.Logique;

namespace Compteur.Logique.Tests;

public class CompteurClicsTests
{
    [Fact]
    public void Demarre_a_zero()
    {
        var compteur = new CompteurClics();
        Assert.Equal(0, compteur.Valeur);
        Assert.Equal("Aucun clic", compteur.Texte);
    }

    [Fact]
    public void Ajouter_augmente_et_accorde_le_texte()
    {
        var compteur = new CompteurClics();
        compteur.Ajouter();
        Assert.Equal("1 clic", compteur.Texte);
        compteur.Ajouter();
        compteur.Ajouter();
        Assert.Equal("3 clics", compteur.Texte);
    }
}
