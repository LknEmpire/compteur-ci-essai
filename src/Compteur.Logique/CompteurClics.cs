namespace Compteur.Logique;

/// <summary>Compteur de clics, sans interface : facile à tester.</summary>
public sealed class CompteurClics
{
    /// <summary>Valeur actuelle du compteur.</summary>
    public int Valeur { get; private set; }

    /// <summary>Ajoute 1 au compteur.</summary>
    public void Ajouter() => Valeur++;

    /// <summary>Texte affiché sous le bouton : « Aucun clic », « 1 clic », « 3 clics ».</summary>
    public string Texte => Valeur switch
    {
        0 => "Aucun clic",
        1 => "1 clic",
        _ => $"{Valeur} clics",
    };
}
