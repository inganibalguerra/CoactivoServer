﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TipoDocumentoDTO{
        public TipoDocumentoDTO()
        {
            Documentos = new List<DocumentoDTO>();
        }
        public int TipoDocumentoId { get; set; }
        public string Nombre { get; set; }
        public virtual List<DocumentoDTO> Documentos { get; set; }
        private DateTime _updateAt;
        public DateTime UpdateAt { get { return _updateAt; } set { _updateAt = new DateTime(); } }
        private DateTime _createdAt;
        public DateTime CreatedAt { get { return _createdAt; } set { _createdAt = new DateTime(); } }
    }
}
