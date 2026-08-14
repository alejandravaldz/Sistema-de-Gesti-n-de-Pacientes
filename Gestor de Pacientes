using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestión_de_Pacientes
{
    public class GestorPaciente
    {
        public List<Paciente> pacientes = new List<Paciente>();


        // Agregar un paciente a la lista
        public void AgregarPaciente(Paciente paciente)
        {
            foreach (Paciente p in pacientes)
            {
                if (p.Cedula == paciente.Cedula)
                {
                    throw new CedulaDuplicada(paciente.Cedula);
                }
            }

            pacientes.Add(paciente);
        }


        // Listar todos los pacientes
        public List<Paciente> ListarPacientes()
        {
            return pacientes;
        }


        // Buscar paciente por cédula
        public Paciente BuscarPaciente(string cedula)
        {
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Cedula == cedula)
                {
                    return paciente;
                }
            }

            throw new PacienteNoEncontrado(cedula);
        }




        // Actualizar paciente
        public void ActualizarPaciente(Paciente pacienteActualizado)
        {
            Paciente paciente = BuscarPaciente(pacienteActualizado.Cedula);

            paciente.Nombre = pacienteActualizado.Nombre;
            paciente.Edad = pacienteActualizado.Edad;
            paciente.Sexo = pacienteActualizado.Sexo;
            paciente.Estado = pacienteActualizado.Estado;
            paciente.Diagnostico = pacienteActualizado.Diagnostico;
        }


        // Eliminar paciente
        public void EliminarPaciente(string cedula)
        {
            Paciente paciente = BuscarPaciente(cedula);

            pacientes.Remove(paciente);
        }


        // Excepción cuando no se encuentra un paciente
        public class PacienteNoEncontrado : Exception
        {
            public PacienteNoEncontrado(string dato)
                : base("No se encuentra un paciente con el dato: " + dato)
            {
            }
        }


        // Excepción cuando la cédula ya existe
        public class CedulaDuplicada : Exception
        {
            public CedulaDuplicada(string cedula)
                : base("Ya existe un paciente con la cédula: " + cedula)
            {
            }
        }
    }
}
