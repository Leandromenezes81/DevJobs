using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevJobs.API.Entities;

namespace DevJobs.API.Persistence.Repositories;

public class JobVacancyRepository : IJobVacancyRepository
{
    private readonly DevJobsContext _context;    
    
    public JobVacancyRepository(DevJobsContext context)
    {
        _context = context;
    }
    public void Add(JobVacancy jobVacancy)
    {
        throw new NotImplementedException();
    }

    public void AddApplication(JobApplication jobApplication)
    {
        throw new NotImplementedException();
    }

    public List<JobVacancy> GetAll()
    {
        throw new NotImplementedException();
    }

    public JobVacancy GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(JobVacancy jobVacancy)
    {
        throw new NotImplementedException();
    }
}
