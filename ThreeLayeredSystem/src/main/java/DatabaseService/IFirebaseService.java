package DatabaseService;

import Webservice.Model.User;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Service;

import java.util.concurrent.ExecutionException;

@Service
@Component
public interface IFirebaseService {
    String saveUserDetails(User user) throws InterruptedException, ExecutionException;
    User getUserDetails(String name) throws InterruptedException, ExecutionException;

    String updateUserDetails(User user)throws InterruptedException, ExecutionException;
    String deleteUser(String name) throws InterruptedException, ExecutionException;
}
