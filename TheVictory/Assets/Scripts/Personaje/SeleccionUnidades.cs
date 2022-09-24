using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SeleccionUnidades : MonoBehaviour
{
   public List<GameObject> listaUnidades = new List<GameObject>();
   public List<GameObject> unidadesSeleccionadas = new List<GameObject>();

   private static SeleccionUnidades _instance;

   public static SeleccionUnidades Instance
   {
      get { return _instance; }
   }

   private void Awake()
   {
      if (_instance != this && _instance != null)
      {
         Destroy(this.gameObject);
      }
      else
      {
         _instance = this;
      }
   }
   
   public void SeleccionClick(GameObject agregaUnidad)
   {
      Deseleccion();
      unidadesSeleccionadas.Add(agregaUnidad);
      agregaUnidad.transform.GetChild(0).gameObject.SetActive(true);
   }

   public void ShiftSeleccionClick(GameObject agregaUnidad)
   {
      if (!unidadesSeleccionadas.Contains(agregaUnidad)) 
      {
         unidadesSeleccionadas.Add(agregaUnidad);
         agregaUnidad.transform.GetChild(0).gameObject.SetActive(true);
      }
      else
      {
         agregaUnidad.transform.GetChild(0).gameObject.SetActive(false);
         unidadesSeleccionadas.Remove(agregaUnidad);
      }
   }

   public void SeleccionDibujo(GameObject agregaUnidad)
   {
      if (!unidadesSeleccionadas.Contains(agregaUnidad))
      {
         unidadesSeleccionadas.Add(agregaUnidad);
         agregaUnidad.transform.GetChild(0).gameObject.SetActive(true);
      }
   }

   public void Deseleccion()
   {
      foreach (var unidad in unidadesSeleccionadas)
      {
         unidad.transform.GetChild(0).gameObject.SetActive(false);
      }
      unidadesSeleccionadas.Clear();
   }

   public void Deseleccionunitaria(GameObject quitarUnidad)
   {
      
   }
}
