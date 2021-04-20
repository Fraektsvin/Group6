package sep3.webservice2ndtier;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ConfigurableApplicationContext;
import sep3.webservice2ndtier.models.usermodel.User;

@SpringBootApplication
public class WebService2ndTierApplication {

    public static void main(String[] args) {
        SpringApplication.run(WebService2ndTierApplication.class, args);

        /*ConfigurableApplicationContext appContext =
                SpringApplication.run(WebService2ndTierApplication.class, args);
        User user = appContext.getBean(User.class);*/

    }

}
