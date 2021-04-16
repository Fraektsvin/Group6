package ClientService;

import DatabaseService.FirebaseService;
import org.springframework.beans.factory.annotation.Configurable;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ConfigurableApplicationContext;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.stereotype.Repository;

@SpringBootApplication
public class mainclass {

    public static void main(String[] args) {
        ApplicationContext ctx = SpringApplication.run(mainclass.class, args);
        ctx.getBean("FirebaseService", FirebaseService.class);
    }
}

