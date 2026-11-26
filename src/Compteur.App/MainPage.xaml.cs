using Compteur.Logique;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Compteur;

/// <summary>Page principale : un bouton « Ajouter » et le texte du compteur.</summary>
public sealed partial class MainPage : Page
{
    private readonly CompteurClics _compteur = new();

    public MainPage()
    {
        InitializeComponent();
        Afficher();
    }

    private void BoutonAjouter_Click(object sender, RoutedEventArgs e)
    {
        _compteur.Ajouter();
        Afficher();
    }

    private void Afficher() => TexteCompteur.Text = _compteur.Texte;
}
