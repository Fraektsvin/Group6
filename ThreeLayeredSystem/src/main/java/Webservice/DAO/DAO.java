package Webservice.DAO;

import java.util.List;

public interface DAO<T> {
    List<T> getAll();
    void addNew(T t);
}
