package sep3.webservice2ndtier.service.userservice;

import sep3.webservice2ndtier.models.usermodel.User;

import java.util.List;

public interface UserService {
    List<User> getAllUsers();
    void createUser(User newUser);
}
