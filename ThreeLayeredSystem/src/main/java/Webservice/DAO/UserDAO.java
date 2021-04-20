package Webservice.DAO;

import Webservice.Model.User;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

@Service
public class UserDAO implements DAO<User>{

    @Autowired
    private List<User> users = new ArrayList<>();

    private String userFile = "users.json";
    private ObjectMapper mapper = new ObjectMapper();
    public UserDAO(){
        readDataFromFile();
    }

    private void readDataFromFile() {
        try {
            List<User> userList = mapper.readValue(new File(userFile), new TypeReference<List<User>>() {
            });
            users = userList;
        } catch (IOException ioException) {
            ioException.printStackTrace();
        }
    }

    @Override
    public List<User> getAll() {
        return users;
    }

    @Override
    public void addNew(User user) {
        users.add(user);
        saveChanges();
    }

    private void saveChanges() {
        try {
            mapper.writeValue(new File(userFile), users);
        } catch (IOException ioException) {
            ioException.printStackTrace();
        }
    }
}
