using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using De.HsFlensburg.ClientApp075.Logic.Ui.Wrapper;

namespace De.HsFlensburg.ClientApp075.Logic.Ui.ViewModels
{
    public class NewClientWindowViewModel
    {
        public int Identifier { get; set; }
        public string Name { get; set; }
        private ClientCollectionViewModel clientcollectionViewModel;
        public ICommand AddClient { get; }
        public NewClientWindowViewModel(ClientCollectionViewModel viewModelCollection)
        {
            AddClient = new RelayCommand(AddClientMethod);
            clientcollectionViewModel = viewModelCollection;
        }
        private void AddClientMethod()
        {
            ClientViewModel cvm = new ClientViewModel();
            cvm.Id = Identifier;
            cvm.Name = Name;
            clientcollectionViewModel.Add(cvm);
        }
    }
}
