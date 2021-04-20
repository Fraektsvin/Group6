package sep3.webservice2ndtier.controllers.usercontroller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import sep3.webservice2ndtier.models.usermodel.User;
import sep3.webservice2ndtier.service.userservice.UserService;

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
