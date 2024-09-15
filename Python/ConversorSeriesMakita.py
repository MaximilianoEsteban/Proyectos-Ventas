import tkinter as tk
from tkinter import filedialog, ttk, messagebox
import xlsxwriter


def select_file():
    global tree, frame, button_guardar
    if tree is not None:
        tree.destroy()
    if frame is not None:
        frame.destroy()
    if button_guardar is not None:
        button_guardar.destroy()

    file_path = filedialog.askopenfilename()
    if file_path:
        process_file(file_path)


def process_file(file_path):
    errores = []

    with open(file_path, mode="r") as objeto_de_io, \
         open("C:/Users/mesteban/Documents/MAKITA/Escaneos/Procesados/maxi.txt", "a") as f:
        
        texto = objeto_de_io.readlines()
        lista_previa = []

        for linea in texto:
            lineas = linea.split()

            if len(lineas) < 2:
                errores.append(linea)
                continue

            datos_producto = lineas[0]
            datos_serie_inicio = int(lineas[1][:9])
            datos_serie_fin = int(lineas[1][9:18])
            datos_serie_letra = lineas[1][18:19].lower()

            for i in range(datos_serie_fin - datos_serie_inicio + 1):
                datos_serie = datos_serie_inicio + i
                datos_serie_str = str(datos_serie).zfill(9)

                lista_previa.append([datos_producto, f"{datos_serie_str}{datos_serie_letra}"])
                f.write(f"{datos_producto}\t\t{datos_serie_str}{datos_serie_letra}\n")

    if errores:
        mostrar_errores(errores)

    crear_grilla(lista_previa)


def mostrar_errores(errores):
    mensaje_error = "Se encontraron errores en las siguientes líneas:\n" + \
                    "\n".join(f"Error: La línea '{error}' no tiene suficientes elementos." for error in errores)
    messagebox.showerror("Errores", mensaje_error)


tree = None
frame = None
button_guardar = None 

def crear_grilla(lista_previa):
    
    global tree, frame, button_guardar  
    
    if tree is not None:
        tree.destroy()
    if frame is not None:
        frame.destroy()
    if button_guardar is not None:  
        button_guardar.destroy()  
    
    frame = tk.Frame(root, borderwidth=1, relief='solid')
    frame.pack(padx=5, pady=5)
    
    tree = ttk.Treeview(frame)
    tree['columns'] = ('Producto', 'Serie')

    tree.column("#0", width=0, stretch=tk.NO)
    tree.column("Producto", anchor=tk.W, width=200)
    tree.column("Serie", anchor=tk.W, width=200)

    tree.heading("#0", text='', anchor=tk.W)
    tree.heading("Producto", text='Producto', anchor=tk.W)
    tree.heading("Serie", text='Serie', anchor=tk.W)

    for i, row in enumerate(lista_previa):
        tag = 'even' if i % 2 == 0 else 'odd'
        tree.insert('', 'end', values=row, tags=(tag,))
    
    tree.pack()

    
    button_guardar = tk.Button(root, text="Guardar", font=("Arial", 14), fg="blue", command=lambda: save_to_excel(lista_previa))
    button_guardar.pack(pady=(10, 0))


def save_to_excel(data):
    file_path = filedialog.asksaveasfilename(defaultextension=".xlsx", filetypes=[("Excel files", "*.xlsx")])
    if file_path:
        with xlsxwriter.Workbook(file_path) as workbook:
            worksheet = workbook.add_worksheet()
            code39_format = workbook.add_format({'font_name': '3 of 9 Barcode', 'font_size': 24})
        
            for i, row in enumerate(data):
                worksheet.write(i, 0, row[0])  # Producto
                worksheet.write(i, 1, row[1])  # Serie
                codigo_barras = "*" + row[1][:-1] + row[1][-1] + "*"
                worksheet.write(i, 2, codigo_barras, code39_format)  # Código de barras
        
        label_confirmacion = tk.Label(root, text="Proceso finalizado con éxito.", font=("Arial", 24), fg="green")
        label_confirmacion.pack()


# Configuración de la ventana
root = tk.Tk()
root.title("Maximiliano Esteban")
root.resizable(False, False)
root.geometry("800x600")

logo = tk.PhotoImage(file="C:\\Users\\mesteban\\Desktop\\Python\\Logo.png")
label_logo = tk.Label(root, image=logo)
label_logo.image = logo
label_logo.pack(pady=(0, 30))

label = tk.Label(root, text="SELECCIONAR UN ARCHIVO", font=("Arial", 18), fg="blue")
label.pack(pady=(0, 30))

button = tk.Button(root, text="Buscar", font=("Arial", 14), fg="blue", command=select_file)
button.pack(pady=(0, 10))

root.mainloop()