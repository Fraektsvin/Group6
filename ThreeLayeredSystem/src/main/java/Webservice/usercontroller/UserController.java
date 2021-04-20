package Webservice.usercontroller;

import Webservice.Pesistence.UserService;
import Webservice.Model.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;


@RestController
@RequestMapping("/users")
public class UserController {
    @Autowired
    UserService userService;

    @GetMapping("/all")
    public User getAllUsers(){
        return (User) userService.getAllUsers();
    }

    @PostMapping("")
    public void createUser(@RequestBody User newUser){
        userService.createUser(newUser);
    }
}
