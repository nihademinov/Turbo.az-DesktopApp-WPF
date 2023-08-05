using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Controls.Primitives;
using Turbo.az_Desktop_App.Models;

namespace Turbo.az_Desktop_App.Database;

public class UserDatabase : INotifyPropertyChanged
{
    private List<UserModel>? _allUsers=new();

    public List<UserModel>? allUsers
    {
        get => _allUsers;
        set
        {
            _allUsers = value;
            WhenPropertyChanged();
        }
    }


    public UserDatabase()
    {
        
        using FileStream fs_2 = new FileStream("Users.json", FileMode.Open);
        allUsers = JsonSerializer.Deserialize<List<UserModel?>>(fs_2);
    }
    public void AddUser(UserModel newUser)
    {
        _allUsers.Add(newUser);
        JsonSerializerOptions op = new JsonSerializerOptions();
        op.WriteIndented = true;
        File.WriteAllText("Users.json", JsonSerializer.Serialize(allUsers, op));
    }

    public bool FindUser(string? gmail)
    {
        for (int i = 0; i < _allUsers?.Count; i++)
        {
            if (_allUsers[i].Gmail==gmail)
            {
                return true;
            }
        }
        return false;
    }
    
    public UserModel ReturnUser(string? gmail)
    {
        for (int i = 0; i < _allUsers?.Count; i++)
        {
            if (_allUsers[i].Gmail == gmail)
            {
                return _allUsers[i];
            }
        }
        return null;
    }


    // ->> InotifyFunction <<-- //

    public event PropertyChangedEventHandler? PropertyChanged;

    public void WhenPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
