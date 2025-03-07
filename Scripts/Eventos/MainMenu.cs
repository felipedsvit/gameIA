using Godot;
using System;

public partial class MainMenu : Control
{
    // Referências aos botões
    private Button _startButton;
    private Button _loadButton;
    private Button _optionsButton;
    private Button _quitButton;

    public override void _Ready()
    {
        // Obtenha referências aos botões
        _startButton = GetNode<Button>("VBoxContainer/StartButton");
        _loadButton = GetNode<Button>("VBoxContainer/LoadButton");
        _optionsButton = GetNode<Button>("VBoxContainer/OptionsButton");
        _quitButton = GetNode<Button>("VBoxContainer/QuitButton");

        // Conecte os sinais dos botões aos métodos
        _startButton.Pressed += OnStartButtonPressed;
        _loadButton.Pressed += OnLoadButtonPressed;
        _optionsButton.Pressed += OnOptionsButtonPressed;
        _quitButton.Pressed += OnQuitButtonPressed;
    }

    private void OnStartButtonPressed()
    {
        GD.Print("Iniciar Jogo");
        // Carregue a cena do jogo principal
        GetTree().ChangeSceneToFile("res://Scenes/Main.tscn");
    }

    private void OnLoadButtonPressed()
    {
        GD.Print("Carregar Jogo");
        // Implemente a lógica para carregar um jogo salvo
    }

    private void OnOptionsButtonPressed()
    {
        GD.Print("Abrir Opções");
        // Implemente a lógica para abrir o menu de opções
    }

    private void OnQuitButtonPressed()
    {
        GD.Print("Sair do Jogo");
        GetTree().Quit(); // Fecha o jogo
    }
}