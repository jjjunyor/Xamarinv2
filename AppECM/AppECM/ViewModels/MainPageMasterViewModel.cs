using AppECM.Model;
using AppECM.Model.ViewModels;
using System.Collections.ObjectModel;

namespace AppECM.ViewModels
{
    public class MainPageMasterViewModel : ViewModelBase
    {

        public ObservableCollection<PageTypeGroup> Groups { get; set; }
           
        public MainPageMasterViewModel()
        {


            Groups = new ObservableCollection<PageTypeGroup> {
            new PageTypeGroup("Principal", "A")
            {
                        new MenuItem { Id = 1,
                                    Title = "Solicitar",
                                    Image ="ic_action_assignment_late" },
                      new MenuItem { Id = 2,
                                    Title = "Histórico",
                                    Image ="ic_action_assignment_late" },


            },
             new PageTypeGroup("Segundo", "B")
            {
                      new MenuItem { Id = 3,
                                    Title = "logoff",
                                    Image ="" },//add image

                     
                   

            },

          };
        }
    }
}
