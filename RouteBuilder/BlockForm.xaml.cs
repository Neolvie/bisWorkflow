using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RouteBuilder.ViewModel.Entities.Route;
using Shared.Extenders;
using Shared.Route.Blocks;

namespace RouteBuilder
{
  /// <summary>
  /// Interaction logic for BlockForm.xaml
  /// </summary>
  public partial class BlockForm : INotifyPropertyChanged
  {
    public BlockView Block { get; set; }

    public BlockType _selectedBlockType;

    public BlockType SelectedBlockType
    {
      get { return _selectedBlockType; }
      set
      {
        _selectedBlockType = value;
        OnPropertyChanged();
      }
    }

    public BlockForm()
    {
      if (Block == null)
        Block = new BlockView();

      InitializeComponent();

      BlockTypeComboBox.ItemsSource = typeof(BlockType).ToList();
      BlockTypeComboBox.DisplayMemberPath = "Value";
      BlockTypeComboBox.SelectedValuePath = "Key";
    }

    public BlockForm(IBlock block) : this()
    {
      Block = new BlockView {Entity = block};
    }

    private void SaveButton_OnClick(object sender, RoutedEventArgs e)
    {
      SelectedBlockType = BlockType.Assignment;
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      var handler = PropertyChanged;

      handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
  }
}
