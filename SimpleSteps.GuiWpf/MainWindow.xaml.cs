using SimpleSteps.Business.Services;
using System.Windows;

namespace SimpleSteps.GuiWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AppUserService _appUserService;
        private readonly LocationService _locationService;
        private readonly RoomService _roomService;


        public MainWindow(AppUserService appUserService, LocationService locationService, RoomService roomService)
        {
            InitializeComponent();

            _appUserService = appUserService;
            var userList = _appUserService.GetAllUsers();
            this.grdAppUsers.ItemsSource = userList;

            _locationService = locationService;
            var locationList = _locationService.GetAll();
            this.grdLocations.ItemsSource = locationList;

            _roomService = roomService;
            var roomList = _roomService.GetAll();
            this.grdRooms.ItemsSource = roomList;

            var firstLocation = locationList.FirstOrDefault();
            if (firstLocation != null)
            {
                this.grdRoomsByLocation.ItemsSource = _roomService.GetAllByLocationId(firstLocation.Id);
            }

        }

        private void btnLoadAppUsers_Click(object sender, RoutedEventArgs e)
        {
            this.grdAppUsers.ItemsSource = null;
            this.grdAppUsers.ItemsSource = _appUserService.GetAllUsers();
        }
    }
}