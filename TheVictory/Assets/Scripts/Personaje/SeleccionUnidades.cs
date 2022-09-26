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
   
   // ReSharper disable Unity.PerformanceAnalysis
   public void SeleccionClick(GameObject agregaUnidad)
   {
      Deseleccion();
      unidadesSeleccionadas.Add(agregaUnidad);
      agregaUnidad.transform.GetChild(0).gameObject.SetActive(true);
      agregaUnidad.GetComponent<Movimiento>().enabled = true;
   }

   // ReSharper disable Unity.PerformanceAnalysis
   public void ShiftSeleccionClick(GameObject agregaUnidad)
   {
      if (!unidadesSeleccionadas.Contains(agregaUnidad)) 
      {
         unidadesSeleccionadas.Add(agregaUnidad);
         agregaUnidad.transform.GetChild(0).gameObject.SetActive(true);
         agregaUnidad.GetComponent<Movimiento>().enabled = true;
      }
      else
      {
         agregaUnidad.GetComponent<Movimiento>().enabled = false;
         agregaUnidad.transform.GetChild(0).gameObject.SetActive(false);
         unidadesSeleccionadas.Remove(agregaUnidad);
      }
   }

   // ReSharper disable Unity.PerformanceAnalysis
   public void SeleccionDibujo(GameObject agregaUnidad)
   {
      if (!unidadesSeleccionadas.Contains(agregaUnidad))
      {
         unidadesSeleccionadas.Add(agregaUnidad);
         agregaUnidad.transform.GetChild(0).gameObject.SetActive(true);
         agregaUnidad.GetComponent<Movimiento>().enabled = false;
      }
   }

   // ReSharper disable Unity.PerformanceAnalysis
   public void Deseleccion()
   {
      foreach (var unidad in unidadesSeleccionadas)
      {
         unidad.GetComponent<Movimiento>().enabled = false;
         unidad.transform.GetChild(0).gameObject.SetActive(false);
      }
      unidadesSeleccionadas.Clear();
   }

   public void Deseleccionunitaria(GameObject quitarUnidad)
   {
      
   }
}
