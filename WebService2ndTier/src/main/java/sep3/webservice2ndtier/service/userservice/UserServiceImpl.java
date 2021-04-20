package sep3.webservice2ndtier.service.userservice;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import sep3.webservice2ndtier.DAO.DAO;
import sep3.webservice2ndtier.models.usermodel.User;

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
