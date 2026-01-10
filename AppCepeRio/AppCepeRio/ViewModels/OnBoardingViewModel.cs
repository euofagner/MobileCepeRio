using AppCepeRio.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppCepeRio.ViewModels;

public partial class OnBoardingViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public ObservableCollection<OnBoardingContent> OnBoardingContents { get; set; } = new();

    public OnBoardingViewModel()
    {
        LoadContent();
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void LoadContent()
    {
        OnBoardingContents.Clear();

        OnBoardingContents.Add(new OnBoardingContent
        {
            Id = 1,
            Title = "O CEPE agora é Mobile!",
            Description = "O seu clube de sempre, agora também no celular.\r\nCom o novo aplicativo, você acompanha eventos, atividades e novidades do CEPE de onde estiver.",
            Image = "onboardingfirstpicture.png"
        });

        OnBoardingContents.Add(new OnBoardingContent
        {
            Id = 2,
            Title = "Lazer, Esporte e Cultura",
            Description = "Quadras, campos, piscinas, eventos e muito mais. \r\nTudo o que o CEPE oferece, agora ao alcance das suas mãos.",
            Image = "secondpic.png"
        });

        OnBoardingContents.Add(new OnBoardingContent
        {
            Id = 3,
            Title = "Um Clube para Todos",
            Description = "Mais do que um espaço de lazer, o CEPE é uma comunidade de sócios unida pela amizade e bem-estar.\r\n🔒 Acesse sua conta e aproveite os benefícios.",
            Image = "thirdpic.png"
        });
    }
}
