package ClientService;

import DatabaseService.FirebaseService;
import DatabaseService.IFirebaseService;
import Webservice.User;
import com.google.firebase.FirebaseApp;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.*;

import java.util.concurrent.ExecutionException;


@RestController
public class UserController {

@Autowired
private IFirebaseService firebaseService;

  @GetMapping("/getUserDetails")
  public User getUserDetails(@RequestHeader String name) throws InterruptedException, ExecutionException {
    return firebaseService.getUserDetails(name);
  }
  @PostMapping("/createNewUser")
  public String  createNewUser(@RequestBody User user) throws ExecutionException, InterruptedException {
    return firebaseService.saveUserDetails(user);
  }
  @DeleteMapping("/deleteUser")
  public String deleteUser(@RequestHeader String name)throws ExecutionException, InterruptedException {
    return firebaseService.deleteUser(name);
  }
  @PutMapping("/updateUser")
  public String updateUser(@RequestBody User user) throws ExecutionException, InterruptedException{
    return firebaseService.updateUserDetails(user);
  }
}
