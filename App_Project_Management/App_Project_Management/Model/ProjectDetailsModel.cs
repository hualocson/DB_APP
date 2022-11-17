using System;
using System.Data;

namespace App_Project_Management.Model
{
    public class ProjectDetailsModel
    {
        public ProjectDetailsModel() {
            projectName = "";
            projectKey = "";
            projectId = 0;
            projectProgress = 0;
            projectDeadline = DateTime.Now;
            projectCreateAt = DateTime.Now;
            projectIsDeleted = false;
            projectCount_Member = 0;
            projectCount_Task = 0;
            company_id = 0;
        }
        public ProjectDetailsModel(DataRow row) {
            this.projectId = int.Parse(row["id"].ToString());
            this.projectName = row["name"].ToString();
            this.projectProgress = int.Parse(row["progress"].ToString());
            this.projectDeadline = Convert.ToDateTime(row["deadline"].ToString());
            this.projectCreateAt = Convert.ToDateTime(row["created_at"].ToString());
            this.projectIsDeleted = bool.Parse(row["is_deleted"].ToString());


            if (!row["company_id"].Equals(System.DBNull.Value))
                this.company_id = int.Parse(row["company_id"].ToString());
            else this.company_id = -1;
            
            this.projectKey = row["key"].ToString();
            this.projectCount_Member = int.Parse(row["count_member"].ToString());
            this.projectCount_Task = int.Parse(row["count_task"].ToString());
        }
        public ProjectDetailsModel(int id)
        {
            ProjectId = id;
            blProject = new BS_Layer.BSProject();
            DataRow projectInfo = blProject.getProjectById(id).Rows[0];
            ProjectName = projectInfo["name"].ToString();
            ProjectProgress = int.Parse(projectInfo["progress"].ToString());

            this.projectDeadline = Convert.ToDateTime(projectInfo["deadline"].ToString());
            this.projectCreateAt = Convert.ToDateTime(projectInfo["created_at"].ToString());
            this.projectIsDeleted = bool.Parse(projectInfo["is_deleted"].ToString());


            if (!projectInfo["company_id"].Equals(System.DBNull.Value))
                this.company_id = int.Parse(projectInfo["company_id"].ToString());
            else this.company_id = -1;

            this.projectKey = projectInfo["key"].ToString();
            string err = "";
            this.projectCount_Member = blProject.countMemberInProject(id, ref err);
            this.projectCount_Task = blProject.countTaskInProject(id, ref err);
        }
        #region field
        string projectName = "";
        string projectKey = "";
        int projectId = 0;
        int projectProgress = 0;
        DateTime projectDeadline = DateTime.Now;
        DateTime projectCreateAt = DateTime.Now;
        bool projectIsDeleted = false;
        int projectCount_Member = 0;
        int projectCount_Task = 0;
        int company_id = 0;

        BS_Layer.BSProject blProject = null;
        #endregion

        #region Properties
        public string ProjectName { get => projectName; set => projectName = value; }
        public string ProjectKey { get => projectKey; set => projectKey = value; }
        public int ProjectId { get => projectId; set => projectId = value; }
        public int ProjectProgress { get => projectProgress; set => projectProgress = value; }
        public DateTime ProjectDeadline { get => projectDeadline; set => projectDeadline = value; }
        public DateTime ProjectCreateAt { get => projectCreateAt; set => projectCreateAt = value; }
        public bool ProjectIsDeleted { get => projectIsDeleted; set => projectIsDeleted = value; }
        public int ProjectCount_Member { get => projectCount_Member; set => projectCount_Member = value; }
        public int ProjectCount_Task { get => projectCount_Task; set => projectCount_Task = value; }
        public int Company_id { get => company_id; set => company_id = value; }
        #endregion

        #region Method
        public bool UpdateProject(ref string err)
        {
            blProject= new BS_Layer.BSProject();
            return blProject.updateProject(ProjectId, ProjectName, ProjectProgress, ProjectDeadline, ProjectCreateAt,Company_id, ProjectKey, ref err);
        }

        public int AddProject(ref string err)
        {
            blProject = new BS_Layer.BSProject();
            return blProject.addProject(ProjectName, ProjectProgress, ProjectDeadline, ProjectCreateAt, Company_id, ProjectKey, ref err);
        }
        public bool DeleteProject(ref string err)
        {
            blProject = new BS_Layer.BSProject();
            return blProject.deleteProject(ProjectId, ref err);
        }
        #endregion
    }
}
