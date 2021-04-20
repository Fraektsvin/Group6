package sep3.webservice2ndtier.DAO;

import java.util.List;

public interface DAO<T> {
    List<T> getAll();
    void addNew(T t);
}
