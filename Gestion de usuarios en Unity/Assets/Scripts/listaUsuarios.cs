using UnityEngine;
using System.Collections.Generic;
public class listaUsuarios : MonoBehaviour
{
    List <Usuario> usuarios = new List<Usuario>();
    public void AgregarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }
    public void AgregarIdUsuario(int id)
    {
        Usuario usuario = new Usuario(id, "", 0);
        usuarios.Add(usuario);
    }
    public void AgregarNombreUsuario(int id, string name)
    {
        Usuario usuario = new Usuario(id, name, 0);
        usuarios.Add(usuario);
    }
    public void AgregarAgeUsuario(int id, string name, int age)
    {
        Usuario usuario = new Usuario(id, name, age);
        usuarios.Add(usuario);
    }
    public void ListaUsuarios()
    {
        foreach (Usuario usuario in usuarios)
        {
            Debug.Log("ID: " + usuario.id + ", Name: " + usuario.name + ", Age: " + usuario.age);
        }
    }
    public void BuscarUsuarios(int id)
    {
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.id == id)
            {
                Debug.Log("ID: " + usuario.id + ", Name: " + usuario.name + ", Age: " + usuario.age);
                //return usuario;
            }
        }
        //return null;
    }
    public Usuario MostrarMayor()
    {
        Usuario usuarioMayor = usuarios[0];
        for (int i = 0; i < usuarios.Count; i++)
        {
            if (usuarios[i].age > usuarioMayor.age)
            {
                usuarioMayor = usuarios[i];
            }
        }
        return usuarioMayor;
    }
    public void EliminarUsuario(int id)
    {
        for (int i = 0; i < usuarios.Count; i++)
        {
            if (usuarios[i].id == id)
            {
                usuarios.RemoveAt(i);
                break;
            }
        }
    }
}
