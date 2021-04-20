package Webservice.Pesistence;

import Webservice.DAO.DAO;
import Webservice.Model.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class UserServiceImpl implements UserService{

    @Autowired
    DAO<User> userDAO;

    @Override
    public List<User> getAllUsers() {
        return userDAO.getAll();
    }



    @Override
    public void createUser(User newUser) {
        userDAO.addNew(newUser);
    }
}
