package Webservice.Pesistence;



import Webservice.Model.User;

import java.util.List;
import java.util.concurrent.ExecutionException;

public interface UserService {

    void createUser(User newUser);
}
