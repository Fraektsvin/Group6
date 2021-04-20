package Webservice.Starter;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class StartApplication {



        public static void main(String[] args) {
            SpringApplication.run(StartApplication.class, args);

        /*ConfigurableApplicationContext appContext =
                SpringApplication.run(WebService2ndTierApplication.class, args);
        User user = appContext.getBean(User.class);*/

        }

    }

