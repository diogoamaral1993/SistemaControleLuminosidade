﻿using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Data;
using SistemaControleLuminosidade.Models;
using System.Collections.Generic;

namespace SistemaControleLuminosidade.Repositore
{
    public class SensorRepositore
    {
        ApplicationContext context;
        public SensorRepositore()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;");
            context = new ApplicationContext(optionsBuilder.Options);
        }
        public List<tb_sensor> BuscarSensoresFuncionando()
        {
            return context.tb_sensor.Where(s => s.tipo_sensor == "Luz" && s.status_sensor == "Funcionando").ToList();
        }

        public List<tb_sensor> BuscarSensoresSubstituicao(int id_sensor)
        {
            return context.tb_sensor.Where(s => s.tipo_sensor == "Luz" && s.status_sensor == "Funcionando" && s.id_sensor != id_sensor).ToList();
        }

        public List<tb_sensor> BuscarSensores()
        {
            return context.tb_sensor.ToList();
        }

        public tb_sensor BuscarSensorPorId(int id_sensor)
        {
            return context.tb_sensor.FirstOrDefault(s => s.id_sensor == id_sensor);
        }

        public void CadastrarSensor(tb_sensor sensor)
        {
            context.tb_sensor.Add(sensor);
            context.SaveChanges();
        }

        public Boolean InformarComoQueimado(tb_sensor sensor)
        {
            sensor.status_sensor = "Queimado";
            sensor.data_fim = DateTime.Now;
            context.tb_sensor.Update(sensor);
            context.SaveChanges();
            return true;
        }

        public Boolean SubstituirSensor(tb_sensor sensor, int id_sensor_substituto)
        {
            var listalampadas = context.tb_lampada.Where(l => l.status_lampada == "Funcionando" && l.id_sensor == sensor.id_sensor).ToList();
         
            foreach (var lampada in listalampadas) 
            {
                lampada.id_sensor = id_sensor_substituto;
                context.tb_lampada.Update(lampada);
            }
            sensor.status_sensor = "Queimado";
            sensor.data_fim = DateTime.Now;
            context.tb_sensor.Update(sensor);
            context.SaveChanges();
            return true;
        }
    }
}
