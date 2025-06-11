using CoffeeTrackerApp.Models;
using CommunityToolkit.Mvvm.Input;

namespace CoffeeTrackerApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}