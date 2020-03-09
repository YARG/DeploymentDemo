using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DVDeploymentDemo.Models;

namespace DVDeploymentDemo.Pages
{
    public class IndexModel : PageModel
    {

        #region module level declarations

        private readonly ILogger<IndexModel> _logger;
        private readonly ToDoDbContext _dbContext;

        #endregion

        #region public properties

        public IEnumerable<ToDoItem> ToDoItems { get; private set; }

        #endregion

        #region ctors

        public IndexModel(ILogger<IndexModel> logger, ToDoDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;

        }

        #endregion

        #region HTTP Handlers

        /// <summary>
        /// HTTP GET
        /// </summary>
        public void OnGet()
        {
            // get the todo list
            ToDoItems = _dbContext.TodoItems.ToList();
        }

        #endregion
    }
}
