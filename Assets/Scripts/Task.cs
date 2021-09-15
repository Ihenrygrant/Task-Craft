using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task
{
	public string name { get; set; }
	public string description { get; set; }

    public List<Appointment> appointments { get; set; }

    public Task(string name, string description, List<Appointment> appointments)
    {
        this.name = name;
        this.description = description;
        this.appointments = appointments;
    }

}
