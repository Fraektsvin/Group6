package Webservice.Pesistence;

import Webservice.DAO.FirebaseService;
import Webservice.Model.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.concurrent.ExecutionException;

@Service
public class UserServiceImpl implements UserService{

    @Autowired
    FirebaseService userDAO;



    @Override
    public void createUser(User newUser)  {
        try {
            userDAO.saveUserDetails(newUser);
        } catch (InterruptedException e) {
            e.printStackTrace();
        } catch (ExecutionException e) {
            e.printStackTrace();
        }
    }
}
