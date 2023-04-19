package com.kh.zoopiter;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.data.jpa.repository.config.EnableJpaAuditing;

@EnableJpaAuditing
@SpringBootApplication
public class ZoopiterApplication {

	public static void main(String[] args) {
		SpringApplication.run(ZoopiterApplication.class, args);
	}

}
