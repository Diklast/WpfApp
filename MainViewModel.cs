// MainViewModel.cs
using System.Collections.ObjectModel;

public class MainViewModel
{
    public ObservableCollection<Biome> Biomes { get; set; } = new ObservableCollection<Biome>();

    public MainViewModel()
    {
        Biomes.Add(new Biome { Name = "Город", CanHostAnimals = false, CanHostMobs = false });
        Biomes.Add(new Biome { Name = "Лес", CanHostAnimals = true, CanHostMobs = false });
        Biomes.Add(new Biome { Name = "Пустыня", CanHostAnimals = false, CanHostMobs = true });
        Biomes.Add(new Biome { Name = "Джунгли", CanHostAnimals = false, CanHostMobs = true });
    }
}
