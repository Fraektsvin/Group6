package Webservice.Pesistence;



import Webservice.Model.User;

import java.util.List;

public interface UserService {
    List<User> getAllUsers();
    void createUser(User newUser);
}